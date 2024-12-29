import { Component } from '@angular/core';
import { ButtonModule } from 'primeng/button';
import { DataViewModule } from 'primeng/dataview';
import { RatingModule } from 'primeng/rating';
import { RecipesService } from '../core/services/recipes.service';
import { AsyncPipe } from '@angular/common';
import { Observable } from 'rxjs';
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
  
    constructor(private service: RecipesService) { 
      this.recipes$ = this.service.recipes$;
    }

}
