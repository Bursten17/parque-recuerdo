import { Component, OnInit, ViewChild, ElementRef } from '@angular/core';

import { TypeNavigation } from '../../../utils/enums';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.scss']
})
export class HeaderComponent implements OnInit {
  isCollapsed = true;
  typeNavigation = TypeNavigation;

  constructor() { }

  ngOnInit(): void {
    var body = document.getElementsByTagName("body")[0];
    body.classList.add("landing-page");
  }

  ngOnDestroy() {
    var body = document.getElementsByTagName("body")[0];
    body.classList.remove("landing-page");
  }

  scrollToTypeNavigationId(id: string) {
    document.getElementById(id).scrollIntoView({ behavior: "smooth" });
  }
}
