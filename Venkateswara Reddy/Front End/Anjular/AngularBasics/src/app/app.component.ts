import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  //String Interpolation
  title = 'Welcome to Angular Training';
  //Property Binding
  public image="/assets/images/img1.jpg"
  //Two-way Binding
  public value=" "
  //Event Binding
  onClick()
  {
    alert("Welcome to Event Binding")
  }
}
