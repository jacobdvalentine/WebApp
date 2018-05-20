import { NgModule } from '@angular/core';
import { ServerModule } from '@angular/platform-server';
import { AppModuleRoot } from './app.module';
import { AppComponent } from './components/app/app.component';

@NgModule({
    bootstrap: [ AppComponent ],
    imports: [
        ServerModule,
        AppModuleRoot
    ]
})
export class AppModule {
}
