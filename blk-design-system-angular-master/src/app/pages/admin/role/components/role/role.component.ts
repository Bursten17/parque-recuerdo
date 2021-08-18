import { Component, OnInit, Input } from '@angular/core';
import { RoleResponse } from '@core/models/response/Role/RoleInterfaceResponse';
import { RoleService } from '@core/services/role.service';
import { ErrorService } from '@core/services/error.service';

@Component({
  selector: 'app-role',
  templateUrl: './role.component.html',
  styleUrls: ['./role.component.scss']
})
export class RoleComponent implements OnInit {
  role: RoleResponse[]

  constructor(
    private roleService: RoleService,
    private errorService: ErrorService
  ) { }

  ngOnInit(): void {
    this.GetAllRoleServices();
  }

  GetAllRoleServices() {
    this.roleService.GetAllRole().subscribe(
      (data) => {
        this.role = data;
      },
      (error) => {
        this.errorService.HandlerError(error)
      }
    )
  }
}
