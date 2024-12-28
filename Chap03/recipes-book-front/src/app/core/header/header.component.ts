import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ButtonModule } from 'primeng/button';

@Component({
    selector: 'app-header',
    imports: [CommonModule, ButtonModule],
    templateUrl: './header.component.html'
})
export class HeaderComponent {

}
