import { Component } from '@angular/core';
import { RecipesListComponent } from '../recipes-list/recipes-list.component';
import { RecipesFilterComponent } from "../recipes-filter/recipes-filter.component";

@Component({
  selector: 'app-home',
  imports: [
    RecipesListComponent,
    RecipesFilterComponent
],
  templateUrl: './home.component.html',
  styleUrl: './home.component.scss'
})
export class HomeComponent {

}
