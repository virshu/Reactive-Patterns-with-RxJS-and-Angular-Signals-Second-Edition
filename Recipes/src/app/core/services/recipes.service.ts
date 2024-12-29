import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Recipe } from '../model/recipe';
import { environment } from '../../../environments/environment';
import { BehaviorSubject, catchError, Observable, of } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class RecipesService {

  recipes$: Observable<Recipe[]>;
  private filterRecipeSubject = new BehaviorSubject<Recipe>({title: ''});
  filterRecipesAction$ = this.filterRecipeSubject.asObservable();

  constructor(private http: HttpClient) { 
    this.recipes$ = this.http.get<Recipe[]>(`${environment.basePath}/recipes`)
      .pipe(catchError(() => of([])));
  }

  updateFilterRecipe(filter: Recipe) {
    this.filterRecipeSubject.next(filter);
  }
}
