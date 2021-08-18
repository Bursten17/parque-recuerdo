import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { RoleRoutingModule } from './role-routing.module';
import { RoleListComponent } from './components/role-list/role-list.component';
import { RoleCreateComponent } from './components/role-create/role-create.component';
import { RoleUpdateComponent } from './components/role-update/role-update.component';
import { RoleItemListComponent } from './components/role-item-list/role-item-list.component';
import { RoleComponent } from './components/role/role.component';
import { MaterialModule } from 'src/app/material/material.module';
import { SharedModule } from 'src/app/shared/shared.module';
import { ReactiveFormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    RoleListComponent,
    RoleCreateComponent,
    RoleUpdateComponent,
    RoleItemListComponent,
    RoleComponent,
  ],
  imports: [
    CommonModule,
    RoleRoutingModule,
    MaterialModule,
    SharedModule,
    ReactiveFormsModule
  ]
})
export class RoleModule { }
