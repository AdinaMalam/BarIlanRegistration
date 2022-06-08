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

  readonly baseURL = 'https://localhost:7193/Users/'
  getInstitution(symbol:string): Observable<Institution>{
    return this.http.get<Institution>(this.baseURL + "GetSymbol/" + symbol)
  }
  
  addUser(user:UserModel):Observable<any>{
  console.log("fghj");
  return this.http.post<any>(this.baseURL + 'AddUser', user,{observe: 'response'})
}

}
