document.addEventListener('DOMContentLoaded', () => {
    // Menu burger
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

    // Animation des compétences
    const observerOptions = {
        threshold: 0.5,
        rootMargin: '0px'
    };

    const observer = new IntersectionObserver((entries) => {
        entries.forEach(entry => {
            if (entry.isIntersecting) {
                entry.target.classList.add('animate');
                observer.unobserve(entry.target);
            }
        });
    }, observerOptions);

    // Observer les barres de progression
    document.querySelectorAll('.skill-bar').forEach(bar => {
        observer.observe(bar);
    });

    // Observer les cercles de compétences
    document.querySelectorAll('.skill-circle').forEach(circle => {
        observer.observe(circle);
    });
});