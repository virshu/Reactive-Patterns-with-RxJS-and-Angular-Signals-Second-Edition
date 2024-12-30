import { Component } from '@angular/core';
import { FormBuilder, ReactiveFormsModule } from '@angular/forms';
import { ButtonModule } from 'primeng/button';
import { InputTextModule } from 'primeng/inputtext';
import { RadioButtonModule } from 'primeng/radiobutton';
import * as recipeTags from '../core/model/tag';
import { RecipesService } from '../core/services/recipes.service';
import { Recipe } from '../core/model/recipe';
import { AsyncPipe } from '@angular/common';
import { catchError, concatMap, of, tap } from 'rxjs';

@Component({
  selector: 'app-recipe-creation',
  imports: [
    ButtonModule,
    RadioButtonModule,
    InputTextModule,
    ReactiveFormsModule,
    AsyncPipe
  ],
  templateUrl: './recipe-creation.component.html',
  styleUrl: './recipe-creation.component.scss'
})
export class RecipeCreationComponent {
  recipeForm: any;
  valueChanges$: any;
  tags = recipeTags.TAGS;

  constructor(private formBuilder: FormBuilder, private service: RecipesService) {
    this.recipeForm = this.formBuilder.group<Recipe>({
      id: Math.floor(1000 + Math.random() * 9000),
      title: '',
      ingredients: '',
      tags: '',
      imageUrl: '',
      cookingTime: undefined,
      yield: 0,
      prepTime: undefined,
      steps: '',
    });

    this.valueChanges$ = this.recipeForm.valueChanges.pipe(
      concatMap((recipe: Recipe) => this.service.createRecipe(recipe)),
      catchError(errors => of(errors)),
      tap(result => this.saveSuccess(result))
    );    
   }

  saveSuccess(result: unknown): void {
    console.log('Save success', result);
  }

}
