import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { EmpleadoService } from '@core/services/empleado.service';
import { ErrorService } from '@core/services/error.service';
import { NotifierService } from 'angular-notifier';

@Component({
  selector: 'app-empleado-create',
  templateUrl: './empleado-create.component.html',
  styleUrls: ['./empleado-create.component.scss']
})
export class EmpleadoCreateComponent implements OnInit {
  sending: boolean = false;
  form: FormGroup;

  constructor(
    private formBuilder: FormBuilder,
    private empleadoService: EmpleadoService,
    private notifierService: NotifierService,
    private errorServices: ErrorService,
    private router: Router
  ) {
    this.buildForm()
   }

  ngOnInit(): void {
  }

  private buildForm() {
    this.form = this.formBuilder.group({
      nombres: [''],
      apellidos: [''],
      fecha_nacimiento: [''],
      afp: [''],
      cargo_id: [''],
      sueldo: [''],
    })
  }

  get nombres_field() {
    return this.form.get('nombres')
  }

  get apellidos_field() {
    return this.form.get('apellidos')
  }

  get fecha_nacimiento_field() {
    return this.form.get('fecha_nacimiento')
  }

  get afp_field() {
    return this.form.get('afp')
  }

  get cargo_id_field() {
    return this.form.get('cargo_id')
  }

  get sueldo_field() {
    return this.form.get('sueldo')
  }

  private disableFormControl() {
    var nombres = this.nombres_field
    var apellidos = this.apellidos_field
    var fecha_nacimiento = this.fecha_nacimiento_field
    var afp = this.afp_field
    var cargo_id = this.cargo_id_field
    var sueldo = this.sueldo_field

    if (this.sending === true) {
      nombres.disable();
      apellidos.disable();
      fecha_nacimiento.disable();
      afp.disable();
      cargo_id.disable();
      sueldo.disable();
    } else {
      nombres.enable();
      apellidos.enable();
      fecha_nacimiento.enable();
      afp.enable();
      cargo_id.enable();
      sueldo.enable();
    }
  }
}
