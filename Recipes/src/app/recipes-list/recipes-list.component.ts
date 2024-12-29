import { Component } from '@angular/core';
import { ButtonModule } from 'primeng/button';
import { DataViewModule } from 'primeng/dataview';
import { RatingModule } from 'primeng/rating';
import { RecipesService } from '../core/services/recipes.service';
import { AsyncPipe } from '@angular/common';

@Component({
  selector: 'app-recipes-list',
  imports: [
    DataViewModule,
    ButtonModule,
    RatingModule,
    AsyncPipe
  ],
  templateUrl: './recipes-list.component.html',
  styleUrl: './recipes-list.component.scss'
})
export class RecipesListComponent {
  recipes$ = this.service.recipes$;

  constructor(private service: RecipesService) { }

}
