import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';
import { Recipe } from '../model/recipe';

@Injectable({
  providedIn: 'root'
})
export class SharedDataService {
  private selectedRecipeSubject = new BehaviorSubject<Recipe | undefined>(undefined);
  selectedRecipe$ = this.selectedRecipeSubject.asObservable();

  constructor() { }

  updateSelectedRecipe(recipe: Recipe) {
    this.selectedRecipeSubject.next(recipe);
  }
  
}
