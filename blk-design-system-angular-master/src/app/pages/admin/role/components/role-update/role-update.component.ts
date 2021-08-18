import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { ActivatedRoute, Params, Router } from '@angular/router';
import { RoleRequest } from '@core/models/request/Role/RoleInterfaceRequest';
import { ErrorService } from '@core/services/error.service';
import { RoleService } from '@core/services/role.service';
import { NotifierService } from 'angular-notifier';

@Component({
  selector: 'app-role-update',
  templateUrl: './role-update.component.html',
  styleUrls: ['./role-update.component.scss']
})
export class RoleUpdateComponent implements OnInit {
  form: FormGroup;
  sending: boolean = false;
  n_id_role: number;

  constructor(
    private formBuilder: FormBuilder,
    private roleService: RoleService,
    private notifierService: NotifierService,
    private errorServices: ErrorService,
    private router: Router,
    private activateRoute: ActivatedRoute
  ) {
    this.buildForm();
  }

  ngOnInit(): void {
    this.GetParam();
  }

  GetRoleByIdService() {
    this.sending = true
    this.disableFormControl()

    this.roleService.GetRoleById(this.n_id_role).subscribe(
      (data) => {
        this.form.patchValue(data)
      },
      (error) => {
        this.errorServices.HandlerError(error);
        this.sending = false
        this.disableFormControl()
      },
      () => {
        this.sending = false
        this.disableFormControl()
      }
    )
  }

  save(event: Event) {
    event.preventDefault()

    if (this.form.invalid) return

    this.UpdateService();
  }

  UpdateService() {
    this.sending = true
    this.disableFormControl()

    const obj: RoleRequest = {
      s_name: this.s_name_field.value,
      s_description: this.s_description_field.value,
      n_state: this.n_state_field.value
    }

    this.roleService.Update(this.n_id_role, obj).subscribe(
      () => {
        this.notifierService.notify('success', 'Role Update')
        this.router.navigate(['/admin/role'])
      },
      (error) => {
        this.errorServices.HandlerError(error);
        this.sending = false
        this.disableFormControl()
      },
      () => {
        this.sending = false
        this.disableFormControl()
      }
    )
  }

  GetParam() {
    this.activateRoute.params.subscribe(
      (parms: Params) => {
        this.n_id_role = parms.id;
        this.GetRoleByIdService()
      }
    )
  }

  onChange(e) {
    if (e.checked == true) this.n_state_field.setValue(1)
    else this.n_state_field.setValue(0)
  }

  get s_name_field() {
    return this.form.get('s_name')
  }

  get s_description_field() {
    return this.form.get('s_description')
  }

  get n_state_field() {
    return this.form.get('n_state')
  }

  private disableFormControl() {
    var s_name = this.s_name_field
    var s_description = this.s_description_field
    var n_state = this.n_state_field

    if (this.sending === true) {
      s_name.disable();
      s_description.disable();
      n_state.disable();
    } else {
      s_name.enable();
      s_description.enable();
      n_state.enable();
    }
  }

  private buildForm() {
    this.form = this.formBuilder.group({
      s_name: ['', [Validators.required]],
      s_description: [''],
      n_state: [1]
    })
  }
}
