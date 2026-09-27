// Small helpers for the portfolio page. Called from Home.razor via JS interop.
window.portfolio = (function () {
    let observer = null;
    const reduceMotion = window.matchMedia("(prefers-reduced-motion: reduce)");

    function scrollToSection(id) {
        const el = document.getElementById(id);
        if (!el) return;
        el.scrollIntoView({ behavior: reduceMotion.matches ? "auto" : "smooth", block: "start" });
        // Move focus for keyboard and screen-reader users without a second jump.
        el.setAttribute("tabindex", "-1");
        el.focus({ preventScroll: true });
    }

    function setActive(id) {
        document.querySelectorAll(".section-nav [data-scroll]").forEach(btn => {
            if (btn.dataset.scroll === id) btn.setAttribute("aria-current", "true");
            else btn.removeAttribute("aria-current");
        });
    }

    function init() {
        // One delegated listener for every [data-scroll] button (nav, footer).
        if (!document.body.dataset.scrollBound) {
            document.body.dataset.scrollBound = "1";
            document.addEventListener("click", e => {
                const btn = e.target.closest("[data-scroll]");
                if (btn) scrollToSection(btn.dataset.scroll);
            });
        }

        // Highlight the nav item for the section currently in view.
        if (observer) observer.disconnect();
        observer = new IntersectionObserver(entries => {
            entries.forEach(entry => {
                if (entry.isIntersecting) setActive(entry.target.id);
            });
        }, { rootMargin: "-35% 0px -60% 0px" });

        document.querySelectorAll("main .section[id]").forEach(s => observer.observe(s));
    }

    return { init, scrollToSection };
})();
