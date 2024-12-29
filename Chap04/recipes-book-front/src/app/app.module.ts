import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { provideHttpClient, withInterceptorsFromDi } from '@angular/common/http';
import { RecipesService } from './core/services/recipes.service';
import { AppRoutingModule } from './app-routing.module';
import { HeaderComponent } from './core/header/header.component';
import { providePrimeNG } from 'primeng/config';
import Aura from '@primeng/themes/aura';

@NgModule({ declarations: [
        AppComponent
    ],
    bootstrap: [AppComponent], imports: [BrowserModule,
        AppRoutingModule,
        HeaderComponent], providers: [
            RecipesService, 
            provideHttpClient(withInterceptorsFromDi()),
            providePrimeNG({
                theme: {
                    preset: Aura
                }
            })
        ] })
export class AppModule { }
