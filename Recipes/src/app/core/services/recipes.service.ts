import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Recipe } from '../model/recipe';
import { environment } from '../../../environments/environment';

@Injectable({
  providedIn: 'root'
})
export class RecipesService {

  recipes$ = this.http.get<Recipe[]>(`${environment.basePath}/recipes`);
  constructor(private http: HttpClient) { }
}
