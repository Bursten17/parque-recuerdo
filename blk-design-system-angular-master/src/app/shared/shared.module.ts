import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule } from '@angular/router';
import { CollapseModule } from "ngx-bootstrap/collapse";
import { ReactiveFormsModule } from "@angular/forms";

import { HeaderComponent } from './components/header/header.component';
import { FooterComponent } from './components/footer/footer.component';
import { ProgressBarComponent } from './components/progress-bar/progress-bar.component';
import { MaterialModule } from '../material/material.module';
import { BootstrapModule } from '../bootstrap/bootstrap.module';
import { QuestionComponent } from './modals/question/question.component';

@NgModule({
  declarations: [HeaderComponent, FooterComponent, ProgressBarComponent, QuestionComponent],
  imports: [
    CommonModule,
    RouterModule,
    CollapseModule,
    ReactiveFormsModule,
    MaterialModule,
    BootstrapModule
  ],
  exports: [
    HeaderComponent,
    FooterComponent,
    ProgressBarComponent,
    QuestionComponent
  ]
})
export class SharedModule { }
