import { Component } from '@angular/core';
import { FormBuilder, ReactiveFormsModule } from '@angular/forms';
import { Recipe } from '../core/model/recipe';
import { RecipesService } from '../core/services/recipes.service';
import { ButtonModule } from 'primeng/button';

@Component({
  selector: 'app-recipes-filter',
  imports: [
    ReactiveFormsModule,
    ButtonModule
  ],
  templateUrl: './recipes-filter.component.html',
  styleUrl: './recipes-filter.component.scss'
})
export class RecipesFilterComponent {
  recipeForm: any;

  constructor(private service: RecipesService, private fb: FormBuilder) {
    this.recipeForm = this.fb.group<Recipe>({
      title: '',
      category: '',
      ingredients: '',
      tags: '',
      prepTime: undefined,
      cookingTime: undefined,
    });
  
  }

  filterResults() {
    this.service.updateFilterRecipe(<Recipe>this.recipeForm.value);
  }

  clearFilters() {
    this.recipeForm.reset();
  }
}
