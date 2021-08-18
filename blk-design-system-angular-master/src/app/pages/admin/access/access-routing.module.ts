import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AccessListComponent } from './components/access-list/access-list.component';

const routes: Routes = [
  {
    path: '',
    component: AccessListComponent
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class AccessRoutingModule { }
