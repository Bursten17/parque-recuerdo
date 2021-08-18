import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { RoleCreateComponent } from './components/role-create/role-create.component';
import { RoleListComponent } from './components/role-list/role-list.component';
import { RoleUpdateComponent } from './components/role-update/role-update.component';
import { RoleComponent } from './components/role/role.component';

const routes: Routes = [
  {
    path: '',
    component: RoleComponent
  },
  {
    path: 'create',
    component: RoleCreateComponent
  },
  {
    path: 'update/:id',
    component: RoleUpdateComponent
  },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class RoleRoutingModule { }
