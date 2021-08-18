import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { AdminRoutingModule } from './admin-routing.module';
import { DashboradComponent } from './components/dashborad/dashborad.component';
import { NavComponent } from './components/nav/nav.component';
import { MaterialModule } from 'src/app/material/material.module';

@NgModule({
  declarations: [DashboradComponent, NavComponent],
  imports: [
    CommonModule,
    AdminRoutingModule,
    MaterialModule
  ]
})
export class AdminModule { }
