import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { Login } from '@core/models/request/auth/loguin.model';
import { AuthService } from '@core/services/auth.service';
import { ErrorService } from '@core/services/error.service';
import { NotifierService } from 'angular-notifier';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit {
  focus: boolean;
  focus1: boolean;
  focus2: boolean;

  form: FormGroup;
  notifier: NotifierService;

  constructor(
    private formBuilder: FormBuilder,
    private authService: AuthService,
    private router: Router,
    notifierService: NotifierService,
    private errorService: ErrorService
  ) {
    this.notifier = notifierService;
    this.buildForm();
  }

  ngOnInit(): void {
  }

  login(event: Event) {
    event.preventDefault();

    if (this.form.invalid) return

    const dataObj: Login = {
      usuario: this.form.value.usuario,
      clave: this.form.value.clave
    }

    this.authService.login(dataObj).subscribe(
      (data) => {
        console.log('data', data)
        this.router.navigate(['/admin']);
      },
      (error) => {
        this.errorService.HandlerError(error)
      }
    )
  }

  private buildForm() {
    this.form = this.formBuilder.group({
      usuario: ['fernando', [Validators.required]],
      clave: ['Qlixim-3', [Validators.required]]
    })
  }
}
