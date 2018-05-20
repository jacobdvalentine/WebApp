import { VehicleService } from './../../services/vehicle.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-vehicle-form',
  templateUrl: './vehicle-form.component.html',
  styleUrls: ['./vehicle-form.component.css']
})
export class VehicleFormComponent implements OnInit {
  // Declare fields to be populated
  makes: any[] = [];
  models: any[] = [];
  features: any[] = [];
  vehicle: any = {};

  // Inject services into constructor
  constructor(private vehicleService: VehicleService) { }

  // Initialze fields using services calls
  ngOnInit() {
    this.vehicleService.getMakes().subscribe(makes => this.makes = makes);
    this.vehicleService.getFeatures().subscribe(features => this.features = features);
  }
  // Event handler for when a change occurs in the Make drop down bar in the vehicle form view
  onMakeChange(){
    //console.log("Vehicle", this.vehicle);
    // Get the models for the currently selected Make, if the selection is not empty
    var selectecdMake = this.makes.find(m => m.id == this.vehicle.make);
    this.models = selectecdMake ? selectecdMake.models : [];
  }


}
