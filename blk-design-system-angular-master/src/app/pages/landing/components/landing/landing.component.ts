import { Component, OnInit } from '@angular/core';

import { TypeNavigation } from '../../../../utils/enums';

@Component({
  selector: 'app-landing',
  templateUrl: './landing.component.html',
  styleUrls: ['./landing.component.scss']
})
export class LandingComponent implements OnInit {
  typeNavigation = TypeNavigation;

  constructor() { }

  ngOnInit(): void {
  }

}
