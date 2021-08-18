import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { EmpleadoRoutingModule } from './empleado-routing.module';
import { EmpleadoComponent } from './components/empleado/empleado.component';
import { EmpleadoCreateComponent } from './components/empleado-create/empleado-create.component';
import { EmpleadoListComponent } from './components/empleado-list/empleado-list.component';
import { EmpleadoUpdateComponent } from './components/empleado-update/empleado-update.component';
import { SharedModule } from 'src/app/shared/shared.module';
import { ReactiveFormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    EmpleadoComponent,
    EmpleadoCreateComponent,
    EmpleadoListComponent,
    EmpleadoUpdateComponent
  ],
  imports: [
    CommonModule,
    EmpleadoRoutingModule,
    SharedModule,
    ReactiveFormsModule
  ]
})
export class EmpleadoModule { }
