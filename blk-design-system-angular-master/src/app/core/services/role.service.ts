import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { RoleRequest } from '@core/models/request/Role/RoleInterfaceRequest';
import { RoleResponse } from '@core/models/response/Role/RoleInterfaceResponse';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class RoleService {
  constructor(
    private http: HttpClient
  ) { }

  GetAllRole() {
    return this.http.get<RoleResponse[]>(`${environment.url_api}/role`)
  }

  GetRoleById(n_id_role: number) {
    return this.http.get<RoleResponse>(`${environment.url_api}/role/${n_id_role}`)
  }

  Create(role: RoleRequest) {
    return this.http.post(`${environment.url_api}/role/create`, role);
  }

  Update(n_id_role: number, changes: Partial<RoleRequest>) {
    return this.http.put(`${environment.url_api}/role/update/${n_id_role}`, changes);
  }

  UpdateState(n_id_role: number, role: Partial<RoleRequest>) {
    return this.http.put(`${environment.url_api}/role/update/${n_id_role}/state`, role);
  }
}
