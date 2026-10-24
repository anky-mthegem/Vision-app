/**
 * VisionStudio User Manual - Interactive Script
 * Provides Search, Lightbox, Copy-to-Clipboard, ScrollSpy, and Theme Toggles
 * Made By <3 by Anky Singh
 */

document.addEventListener('DOMContentLoaded', () => {
    initTheme();
    initScrollSpy();
    initSearch();
    initLightbox();
    initCopyButtons();
    initMobileMenu();
});

// ---------------------------------------------------------------------------
// 1. Theme Toggle (Dark / Light)
// ---------------------------------------------------------------------------
function initTheme() {
    const toggleBtn = document.getElementById('themeToggleBtn');
    if (!toggleBtn) return;

    const savedTheme = localStorage.getItem('visionstudio_manual_theme') || 'dark';
    document.documentElement.setAttribute('data-theme', savedTheme);
    updateThemeIcon(toggleBtn, savedTheme);

    toggleBtn.addEventListener('click', () => {
        const currentTheme = document.documentElement.getAttribute('data-theme') || 'dark';
        const nextTheme = currentTheme === 'dark' ? 'light' : 'dark';
        document.documentElement.setAttribute('data-theme', nextTheme);
        localStorage.setItem('visionstudio_manual_theme', nextTheme);
        updateThemeIcon(toggleBtn, nextTheme);
    });
}

function updateThemeIcon(btn, theme) {
    btn.innerHTML = theme === 'dark' ? '☀️' : '🌙';
    btn.setAttribute('title', `Switch to ${theme === 'dark' ? 'Light' : 'Dark'} Mode`);
}

// ---------------------------------------------------------------------------
// 2. ScrollSpy for Sidebar Active State
// ---------------------------------------------------------------------------
function initScrollSpy() {
    const sections = document.querySelectorAll('section.doc-section, .hero-card');
    const navItems = document.querySelectorAll('.sidebar-nav-item');

    if (sections.length === 0 || navItems.length === 0) return;

    window.addEventListener('scroll', () => {
        let currentSectionId = '';
        const scrollPosition = window.scrollY + 140;

        sections.forEach(section => {
            const top = section.offsetTop;
            const height = section.offsetHeight;
            if (scrollPosition >= top && scrollPosition < top + height) {
                currentSectionId = section.getAttribute('id');
            }
        });

        navItems.forEach(item => {
            item.classList.remove('active');
            const link = item.querySelector('a');
            if (link && link.getAttribute('href') === `#${currentSectionId}`) {
                item.classList.add('active');
            }
        });
    });
}

// ---------------------------------------------------------------------------
// 3. Search Filter
// ---------------------------------------------------------------------------
function initSearch() {
    const searchInput = document.getElementById('manualSearchInput');
    if (!searchInput) return;

    // Keyboard shortcut (Ctrl+K or '/')
    window.addEventListener('keydown', (e) => {
        if ((e.ctrlKey && e.key === 'k') || (e.key === '/' && document.activeElement !== searchInput)) {
            e.preventDefault();
            searchInput.focus();
            searchInput.select();
        } else if (e.key === 'Escape' && document.activeElement === searchInput) {
            searchInput.blur();
        }
    });

    searchInput.addEventListener('input', (e) => {
        const query = e.target.value.toLowerCase().trim();
        const cards = document.querySelectorAll('section.doc-section, .formula-card, .feature-box, tr.tool-row');

        if (!query) {
            cards.forEach(card => card.style.display = '');
            return;
        }

        cards.forEach(card => {
            const text = card.textContent.toLowerCase();
            if (text.includes(query)) {
                card.style.display = '';
            } else {
                card.style.display = 'none';
            }
        });
    });
}

// ---------------------------------------------------------------------------
// 4. Image Lightbox
// ---------------------------------------------------------------------------
function initLightbox() {
    const modal = document.getElementById('lightboxModal');
    const modalImg = document.getElementById('lightboxImg');
    const modalCaption = document.getElementById('lightboxCaption');
    const closeBtn = document.getElementById('lightboxClose');

    if (!modal || !modalImg) return;

    document.querySelectorAll('.screenshot-container img').forEach(img => {
        img.addEventListener('click', () => {
            modalImg.src = img.src;
            modalCaption.textContent = img.alt || 'VisionStudio Interface Screenshot';
            modal.classList.add('active');
            document.body.style.overflow = 'hidden';
        });
    });

    const closeModal = () => {
        modal.classList.remove('active');
        document.body.style.overflow = '';
    };

    if (closeBtn) closeBtn.addEventListener('click', closeModal);
    modal.addEventListener('click', (e) => {
        if (e.target === modal || e.target === modalImg) closeModal();
    });

    window.addEventListener('keydown', (e) => {
        if (e.key === 'Escape' && modal.classList.contains('active')) {
            closeModal();
        }
    });
}

// ---------------------------------------------------------------------------
// 5. One-Click Copy Buttons
// ---------------------------------------------------------------------------
function initCopyButtons() {
    document.querySelectorAll('.copy-btn').forEach(btn => {
        btn.addEventListener('click', () => {
            const targetId = btn.getAttribute('data-target');
            let textToCopy = '';

            if (targetId) {
                const el = document.getElementById(targetId);
                if (el) textToCopy = el.textContent.trim();
            } else {
                const pre = btn.closest('.code-wrapper')?.querySelector('pre');
                const formula = btn.closest('.formula-card')?.querySelector('.formula-syntax');
                if (formula) textToCopy = formula.textContent.trim();
                else if (pre) textToCopy = pre.textContent.trim();
            }

            if (!textToCopy) return;

            navigator.clipboard.writeText(textToCopy).then(() => {
                const originalText = btn.innerHTML;
                btn.innerHTML = '✓ Copied!';
                btn.style.color = '#00e676';
                btn.style.borderColor = '#00e676';
                setTimeout(() => {
                    btn.innerHTML = originalText;
                    btn.style.color = '';
                    btn.style.borderColor = '';
                }, 2000);
            }).catch(err => {
                console.error('Clipboard copy failed:', err);
            });
        });
    });
}

// ---------------------------------------------------------------------------
// 6. Mobile Sidebar Navigation
// ---------------------------------------------------------------------------
function initMobileMenu() {
    const toggleBtn = document.getElementById('mobileMenuBtn');
    const sidebar = document.querySelector('aside.manual-sidebar');

    if (!toggleBtn || !sidebar) return;

    toggleBtn.addEventListener('click', () => {
        sidebar.classList.toggle('open');
    });

    // Close on navigation click on small screens
    sidebar.querySelectorAll('a').forEach(link => {
        link.addEventListener('click', () => {
            if (window.innerWidth <= 1024) {
                sidebar.classList.remove('open');
            }
        });
    });
}
