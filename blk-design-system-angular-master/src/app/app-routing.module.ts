import { NgModule } from "@angular/core";
import { CommonModule } from "@angular/common";
import { BrowserModule } from "@angular/platform-browser";
import { Routes, RouterModule, PreloadAllModules } from "@angular/router";

import { IndexComponent } from "./pages/index/index.component";
import { ProfilepageComponent } from "./pages/examples/profilepage/profilepage.component";
import { RegisterpageComponent } from "./pages/examples/registerpage/registerpage.component";
import { LandingpageComponent } from "./pages/examples/landingpage/landingpage.component";
import { LayoutComponent } from "./layout/layout.component";
import { AdminGuard } from "./guards/admin.guard";

const routes: Routes = [
  {
    path: 'component',
    component: LayoutComponent,
    children: [
      { path: "", redirectTo: "home", pathMatch: "full" },
      { path: "home", component: IndexComponent },
      { path: "profile", component: ProfilepageComponent },
      { path: "register", component: RegisterpageComponent },
      { path: "landing", component: LandingpageComponent },
    ]
  },
  {
    path: 'login',
    loadChildren: () => import('./pages/auth/auth.module').then(x => x.AuthModule)
  },
  {
    path: '',
    component: LayoutComponent,
    children: [
      {
        path: '',
        redirectTo: '/home',
        pathMatch: 'full',
      },
      {
        path: 'home',
        loadChildren: () => import('./pages/landing/landing.module').then(x => x.LandingModule)
      },
      {
        path: 'devealopments',
        loadChildren: () => import('./pages/project/project.module').then(x => x.ProjectModule)
      }
    ]
  },
  {
    path: 'admin',
    canActivate: [AdminGuard],
    loadChildren: () => import('@page/admin/admin.module').then(x => x.AdminModule)
  },
  {
    path: '**',
    loadChildren: () => import('@page/not-found/not-found.module').then(m => m.NotFoundModule)
  }
];

@NgModule({
  imports: [
    CommonModule,
    BrowserModule,
    RouterModule.forRoot(routes, {
      useHash: true,
      preloadingStrategy: PreloadAllModules
    })
  ],
  exports: []
})
export class AppRoutingModule { }
