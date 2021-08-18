import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { UserModuleResponse } from '@core/models/response/User/UserInterfaceResponse';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  constructor(
    private http: HttpClient
  ) { }

  GetMenuByIdRole() {
    return this.http.get<UserModuleResponse>(`${environment.url_api}/user/menu`)
  }
}
