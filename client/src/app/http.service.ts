import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Institution } from './models/Institution';
import { UserModel } from './models/user-model';

@Injectable({
  providedIn: 'root'
})
export class HttpService {

  constructor(private http:HttpClient) { }
  readonly baseURL = window.location.hostname ===  'localhost' ? 'https://localhost:7193/' : 'http://updatews.biu-edulab.org.il/';
  getInstitution(symbol:string): Observable<Institution>{
    return this.http.get<Institution>(this.baseURL + "Users/GetSymbol/" + symbol)
  }
  
  addUser(user:UserModel):Observable<any>{
  return this.http.post<any>(this.baseURL + 'Users/AddUser', user,{observe: 'response'})
}

}
