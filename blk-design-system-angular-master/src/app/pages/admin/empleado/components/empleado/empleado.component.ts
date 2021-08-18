import { Component, OnInit } from '@angular/core';
import { EmpleadoResponse } from '@core/models/response/Empleado/EmpleadoInterfaceResponse';
import { EmpleadoService } from '@core/services/empleado.service';
import { ErrorService } from '@core/services/error.service';

@Component({
  selector: 'app-empleado',
  templateUrl: './empleado.component.html',
  styleUrls: ['./empleado.component.scss']
})
export class EmpleadoComponent implements OnInit {
  empleados: EmpleadoResponse[]

  constructor(
    private empleadoService: EmpleadoService,
    private errorService: ErrorService
  ) { }

  ngOnInit(): void {
    this.GetAllEmpleadosServices()
  }

  GetAllEmpleadosServices() {
    this.empleadoService.GetAllEmpleados().subscribe(
      (data) => {
        console.log(data)
        this.empleados = data;
      },
      (error) => {
        this.errorService.HandlerError(error)
      }
    )
  }
}
