import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { EmpleadoCreateComponent } from './components/empleado-create/empleado-create.component';
import { EmpleadoUpdateComponent } from './components/empleado-update/empleado-update.component';
import { EmpleadoComponent } from './components/empleado/empleado.component';

const routes: Routes = [
  {
    path: '',
    component: EmpleadoComponent
  },
  {
    path: 'create',
    component: EmpleadoCreateComponent
  },
  {
    path: 'update/:id',
    component: EmpleadoUpdateComponent
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class EmpleadoRoutingModule { }
