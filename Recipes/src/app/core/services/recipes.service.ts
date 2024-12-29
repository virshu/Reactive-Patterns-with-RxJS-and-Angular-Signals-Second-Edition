import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Recipe } from '../model/recipe';
import { environment } from '../../../environments/environment';
import { catchError, Observable, of } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class RecipesService {

  recipes$: Observable<Recipe[]>;
  constructor(private http: HttpClient) { 
    this.recipes$ = this.http.get<Recipe[]>(`${environment.basePath}/recipes`)
      .pipe(catchError(() => of([])));
  }
}
