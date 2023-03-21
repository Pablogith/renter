import {Component} from '@angular/core';
import {CommonModule} from '@angular/common';
import {RouterLink, RouterLinkActive} from "@angular/router";

@Component({
  selector: 'renter-sidebar-layout',
  standalone: true,
  imports: [CommonModule, RouterLink, RouterLinkActive],
  templateUrl: './sidebar-layout.component.html',
  styleUrls: ['./sidebar-layout.component.scss']
})
export class SidebarLayoutComponent {
  protected isProfileDropdownShow = false;
  protected isMobileMenuShow = false;

  protected hideProfileDropdown(): void {
    this.isProfileDropdownShow = false;
  }

  protected showProfileDropdown(): void {
    this.isProfileDropdownShow = true;
  }

  protected hideMobileMenu(): void {
    this.isMobileMenuShow = false;
  }

  protected showMobileMenu(): void {
    this.isMobileMenuShow = true;
  }
}
