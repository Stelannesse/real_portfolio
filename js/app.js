document.addEventListener('DOMContentLoaded', () => {
    const menuIcon = document.querySelector('.menu-icon');
    const navbar = document.querySelector('.navbar');
    const body = document.body;

    // Créer l'élément overlay
    const overlay = document.createElement('div');
    overlay.classList.add('menu-overlay');
    body.appendChild(overlay);

    menuIcon.addEventListener('click', () => {
        navbar.classList.toggle('active');
        menuIcon.classList.toggle('active');
        overlay.classList.toggle('active');
        body.style.overflow = navbar.classList.contains('active') ? 'hidden' : 'auto';
    });

    // Fermer le menu en cliquant sur l'overlay
    overlay.addEventListener('click', () => {
        navbar.classList.remove('active');
        menuIcon.classList.remove('active');
        overlay.classList.remove('active');
        body.style.overflow = 'auto';
    });

    // Fermer le menu en cliquant sur un lien
    document.querySelectorAll('.navbar a').forEach(link => {
        link.addEventListener('click', () => {
            navbar.classList.remove('active');
            menuIcon.classList.remove('active');
            overlay.classList.remove('active');
            body.style.overflow = 'auto';
        });
    });
});