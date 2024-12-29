import { Component } from '@angular/core';
import { ButtonModule } from 'primeng/button';
import { DataViewModule } from 'primeng/dataview';
import { RatingModule } from 'primeng/rating';
import { RecipesService } from '../core/services/recipes.service';
import { AsyncPipe } from '@angular/common';
import { combineLatest, map, Observable } from 'rxjs';
import { Recipe } from '../core/model/recipe';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-recipes-list',
  imports: [
    FormsModule,
    DataViewModule,
    ButtonModule,
    RatingModule,
    AsyncPipe
  ],
  templateUrl: './recipes-list.component.html',
  styleUrl: './recipes-list.component.scss'
})
export class RecipesListComponent {
    recipes$: Observable<Recipe[]>;
    filterRecipesAction$: Observable<Recipe>;
    filteredRecipes$: Observable<Recipe[]>;
  
    constructor(private service: RecipesService) { 
      this.recipes$ = this.service.recipes$;
      this.filterRecipesAction$ = this.service.filterRecipesAction$;

      this.filteredRecipes$ = combineLatest([this.recipes$, this.filterRecipesAction$]).pipe(
        map(([recipes, filter]: [Recipe[], Recipe]) => {
          const filterTitle = filter?.title?.toLowerCase() ?? '';
          return recipes.filter(recipe => recipe.title?.toLowerCase().includes(filterTitle));
        })
      );
    }

}
