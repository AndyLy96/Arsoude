import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { TrailDTO } from '../models/TrailDTO';
import { lastValueFrom } from 'rxjs';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class AdminService {

  constructor(private http: HttpClient, private router: Router) {}
  private baseUrl = environment.apiUrl + 'api/Admin/'

  async GetWork(){
    try{
      let x = await lastValueFrom(this.http.get<TrailDTO[]>(this.baseUrl+"GetToBeApproved"))
      return x;
    }
    catch(error) {
      throw error;
    }
  }

  async SetStatus(isApproved : boolean, Trailid : number){
    try{
    let x = await lastValueFrom(this.http.get<any>(this.baseUrl+"EvaluateTrail/"+Trailid+"/"+isApproved))
    console.log(x)
    this.router.navigate(["approve"]);
    }
    catch(error){
      throw error;
    }
  }

  async DeleteTrail(trailid :number){
    try {
      let x = await lastValueFrom(this.http.delete<any>(this.baseUrl+"DeleteTrail/"+trailid))
    } catch (error) {
      throw error;
    }
  }

async ApplyMigrations(){
  try {
    let x = await lastValueFrom(this.http.get<any>(this.baseUrl+"ApplyMigrations"))
  } catch (error) {
    throw error;
  }
}

}
