import { Component, Input, OnInit } from '@angular/core';
import { MatDialog } from '@angular/material/dialog';
import { RoleRequest } from '@core/models/request/Role/RoleInterfaceRequest';
import { RoleResponse } from '@core/models/response/Role/RoleInterfaceResponse';
import { ErrorService } from '@core/services/error.service';
import { RoleService } from '@core/services/role.service';
import { NotifierService } from 'angular-notifier';
import { QuestionComponent } from 'src/app/shared/modals/question/question.component';

@Component({
  selector: 'app-role-list',
  templateUrl: './role-list.component.html',
  styleUrls: ['./role-list.component.scss']
})
export class RoleListComponent implements OnInit {
  @Input() roles: RoleResponse[]

  constructor(
    public dialog: MatDialog,
    private roleService: RoleService,
    private notifierService: NotifierService,
    private errorServices: ErrorService,
  ) {
  }

  openDialog(index: any, e) {
    const dialogRef = this.dialog.open(QuestionComponent, {
      panelClass: 'dialog-container-custom'
    })
    dialogRef.afterClosed().subscribe(
      result => {
        if (!result) {
          if (e.checked) {
            this.roles[index].n_state = 0
          } else {
            this.roles[index].n_state = 1
          }
        } else {
          this.UpdateStateServices(this.roles[index].n_id_role, index)
        }
      }
    )
  }

  ngOnInit(): void {
    console.log('que me llego ', this.roles)
  }

  UpdateStateServices(n_id_role: number, index) {
    const obj: Partial<RoleRequest> = {
      n_state: this.roles[index].n_state
    }

    this.roleService.UpdateState(n_id_role, obj).subscribe(
      () => {
        this.notifierService.notify('success', 'State Changed')
      },
      (error) => {
        this.errorServices.HandlerError(error)
      },
      () => {

      }
    )
  }

  onChange(e, index: any) {
    if (e.checked) {
      this.roles[index].n_state = 1
    } else {
      this.roles[index].n_state = 0
    }
    this.openDialog(index, e);
  }

  getItem(index, indexAux) {
    index === indexAux
  }
}
