// Layout JavaScript functions
window.CoreFWLayout = {
  // Toggle sidebar on mobile
  toggleSidebar: function() {
    const sidebar = document.querySelector('.sidebar');
    if (sidebar) {
      sidebar.classList.toggle('show');
    }
  },
  
  // Close sidebar on mobile when clicking outside
  initSidebarClose: function() {
    const sidebar = document.querySelector('.sidebar');
    const mainContent = document.querySelector('.main-content');
    
    if (sidebar && mainContent && window.innerWidth < 768) {
      mainContent.addEventListener('click', function() {
        sidebar.classList.remove('show');
      });
    }
  },
  
  // Toggle submenu
  toggleSubmenu: function(element) {
    const parentLi = element.closest('li');
    const submenu = parentLi.querySelector('.nav-submenu');
    const arrow = element.querySelector('.nav-arrow');
    
    if (submenu) {
      const isExpanded = submenu.classList.contains('show');
      
      // Close all other submenus
      const allSubmenus = document.querySelectorAll('.nav-submenu.show');
      const allArrows = document.querySelectorAll('.nav-arrow');
      
      allSubmenus.forEach(menu => {
        if (menu !== submenu) {
          menu.classList.remove('show');
        }
      });
      
      allArrows.forEach(arr => {
        if (arr !== arrow) {
          arr.style.transform = 'rotate(0deg)';
        }
      });
      
      // Toggle current submenu
      submenu.classList.toggle('show');
      
      if (arrow) {
        arrow.style.transform = isExpanded ? 'rotate(0deg)' : 'rotate(90deg)';
      }
    }
  }
}; 