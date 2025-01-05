import { Component } from '@angular/core';
import { SharedDataService } from '../core/services/shared-data.service';
import { Observable } from 'rxjs';
import { Recipe } from '../core/model/recipe';
import { AsyncPipe } from '@angular/common';

@Component({
  selector: 'app-recipe-details',
  imports: [
    AsyncPipe
  ],
  templateUrl: './recipe-details.component.html',
  styleUrl: './recipe-details.component.scss'
})
export class RecipeDetailsComponent {
  selectedRecipe$: Observable<Recipe | undefined>; 
  
  constructor(private sharedService: SharedDataService) { 
    this.selectedRecipe$ = this.sharedService.selectedRecipe$;
  }

}
