
import { Routes, ChildActivationEnd } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { MemberListsComponent } from './member-lists/member-lists.component';
import { ListsComponent } from './lists/lists.component';
import { MessagesComponent } from './messages/messages.component';
import { AuthGuard } from './_guards/auth.guard';

export const appRoutes: Routes = [
    {path: 'home', component: HomeComponent },
    {path: '',
    runGuardsAndResolvers: 'always',
    canActivate: [AuthGuard],
    children: [
        {path: 'members', component: MemberListsComponent, canActivate: [AuthGuard] },
        {path: 'lists', component: ListsComponent },
        {path: 'messages', component: MessagesComponent }
    ]}
   ,
    {path: '**' , redirectTo : 'home', pathMatch: 'full' }
];
