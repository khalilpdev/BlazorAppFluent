// Detect system theme preference
function getSystemTheme() {
    return window.matchMedia && window.matchMedia('(prefers-color-scheme: dark)').matches;
}

// Apply theme to the document
function applyTheme(isDarkMode) {
    const htmlElement = document.documentElement;
    
    if (isDarkMode) {
        htmlElement.setAttribute('data-bs-theme', 'dark');
        htmlElement.classList.add('dark-theme');
        htmlElement.classList.remove('light-theme');
    } else {
        htmlElement.setAttribute('data-bs-theme', 'light');
        htmlElement.classList.add('light-theme');
        htmlElement.classList.remove('dark-theme');
    }
}

// Check for saved preference or system preference on page load
function initializeTheme() {
    const savedTheme = localStorage.getItem('theme-preference');
    
    if (savedTheme) {
        applyTheme(savedTheme === 'dark');
    } else {
        const systemDarkMode = getSystemTheme();
        applyTheme(systemDarkMode);
    }
}

// Run on page load
document.addEventListener('DOMContentLoaded', initializeTheme);
