import { Component, OnInit } from '@angular/core';
import { BreakpointObserver, Breakpoints } from '@angular/cdk/layout';
import { Observable } from 'rxjs';
import { map, shareReplay } from 'rxjs/operators';
import { UserService } from '@core/services/user.service';
import { NotifierService } from 'angular-notifier';
import { UserModuleResponse } from '@core/models/response/User/UserInterfaceResponse';
import { ErrorService } from '@core/services/error.service';

@Component({
  selector: 'app-nav',
  templateUrl: './nav.component.html',
  styleUrls: ['./nav.component.scss']
})
export class NavComponent implements OnInit {
  isExpanded = true;
  showSubmenu: boolean = false;
  isShowing = false;
  showSubSubMenu: boolean = false;
  notifier: NotifierService;
  menu: UserModuleResponse

  isHandset$: Observable<boolean> = this.breakpointObserver.observe(Breakpoints.Handset)
    .pipe(
      map(result => result.matches),
      shareReplay()
    );

  constructor(
    private breakpointObserver: BreakpointObserver,
    private userService: UserService,
    private errorService: ErrorService
  ) {
  }

  ngOnInit(): void {
    this.GetMenuByIdRoleServices();
  }

  GetMenuByIdRoleServices() {
    this.userService.GetMenuByIdRole().subscribe(
      (data) => {
        this.menu = data;
      },
      (error) => {
        this.errorService.HandlerError(error)
      }
    )
  }

  mouseenter() {
    if (!this.isExpanded) {
      this.isShowing = true;
    }
  }

  mouseleave() {
    if (!this.isExpanded) {
      this.isShowing = false;
    }
  }
}
