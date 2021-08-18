import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { RoleRequest } from '@core/models/request/Role/RoleInterfaceRequest';
import { ErrorService } from '@core/services/error.service';
import { RoleService } from '@core/services/role.service';
import { NotifierService } from 'angular-notifier';

@Component({
  selector: 'app-role-create',
  templateUrl: './role-create.component.html',
  styleUrls: ['./role-create.component.scss']
})
export class RoleCreateComponent implements OnInit {
  sending: boolean = false;
  form: FormGroup;

  constructor(
    private formBuilder: FormBuilder,
    private roleService: RoleService,
    private notifierService: NotifierService,
    private errorServices: ErrorService,
    private router: Router
  ) {
    this.buildForm()
  }

  ngOnInit(): void {
  }

  save(event: Event) {
    event.preventDefault()

    if (this.form.invalid) return

    this.createService()
  }

  createService() {
    this.sending = true
    this.disableFormControl()

    const obj: RoleRequest = {
      s_name: this.s_name_field.value,
      s_description: this.s_description_field.value,
      n_state: this.n_state_field.value
    }

    this.roleService.Create(obj).subscribe(
      () => {
        this.notifierService.notify('success', 'Role Create')
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

  onChange(e) {
    if (e.checked == true) this.n_state_field.setValue(1)
    else this.n_state_field.setValue(0)
  }

  private buildForm() {
    this.form = this.formBuilder.group({
      s_name: ['', [Validators.required]],
      s_description: [''],
      n_state: [1]
    })
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
}
