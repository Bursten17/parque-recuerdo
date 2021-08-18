import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { LandingRoutingModule } from './landing-routing.module';
import { CarouselModule } from "ngx-bootstrap/carousel";

import { AboutUsComponent } from './components/about-us/about-us.component';
import { OurMissionComponent } from './components/our-mission/our-mission.component';
import { CharacteristicsComponent } from './components/characteristics/characteristics.component';
import { FounderComponent } from './components/founder/founder.component';
import { ProjectComponent } from './components/project/project.component';
import { BannerComponent } from './components/banner/banner.component';
import { LandingComponent } from './components/landing/landing.component';

@NgModule({
  declarations: [AboutUsComponent, OurMissionComponent, CharacteristicsComponent, FounderComponent, ProjectComponent, BannerComponent, LandingComponent],
  imports: [
    CommonModule,
    LandingRoutingModule,
    CarouselModule
  ]
})
export class LandingModule { }
