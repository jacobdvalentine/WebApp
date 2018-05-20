import { Injectable } from '@angular/core';
import { Http } from '@angular/http';
import 'rxjs/add/operator/map';

// Service for Vehicle api
@Injectable()
export class VehicleService {

  constructor(private http: Http) { }

  // Get function to the makes model
  getMakes() {
    return this.http.get('/api/makes').map(res => res.json());
  }

  // Get function to the features model, mapping a response to json
  getFeatures() {
    return this.http.get('/api/features').map(response => response.json);
  }
}
