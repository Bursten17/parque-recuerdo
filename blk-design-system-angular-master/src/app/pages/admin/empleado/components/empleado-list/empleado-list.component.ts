import { Component, Input, OnInit } from '@angular/core';
import { EmpleadoResponse } from '@core/models/response/Empleado/EmpleadoInterfaceResponse';

@Component({
  selector: 'app-empleado-list',
  templateUrl: './empleado-list.component.html',
  styleUrls: ['./empleado-list.component.scss']
})
export class EmpleadoListComponent implements OnInit {
  @Input() empleados: EmpleadoResponse[]

  constructor() { }

  ngOnInit(): void {
    console.log('que me llego ', this.empleados)
  }

}
