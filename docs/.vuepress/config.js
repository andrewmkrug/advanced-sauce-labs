module.exports = {
  title: 'Advanced Selenium Workshop',
  description: 'Online workshop excercises for advanced Selenium and working with Sauce Labs.',
  themeConfig: {
    nav: [
      { text: 'Home', link: '/' },
      { text: 'About', link: '/about/' },
      { text: 'Contact', link: '/contact/' }
    ],
    sidebar: [
      
      {
        title: 'Exercises',
        collapsable: false,
        children: [
          '/exercises/one.md',
          '/exercises/one.md',
          '/exercises/one.md'
          // {
          //   text: 'Join Slack Channel',
          //   link: ''
          // },

        ]
      }
    ]
  },
  markdown: {
    lineNumbers: true
  },
  plugins: {
    'tabs': true,
    // Pass: {
    //   url: 'https://bundle.aerobaticapp.com',
    //   redirectUri: 'https://bundle.aerobaticapp.com/callback',
    //   clientId: 'D3Fq5_CDGCjkE9_JBnbx0Rw7fhgByBro',
    // },
    '@vuepress/back-to-top': true,
    '@vuepress/plugin-notification': false,
    '@vuepress/plugin-back-to-top': true,
    '@vuepress/pwa': {
      serviceWorker: true,
      popupComponent: 'SWUpdatePopup',
      updatePopup: {
        message: "New content is available.",
        buttonText: "Refresh"
      }
    },
    '@vuepress/medium-zoom': true,
    '@vuepress/plugin-active-header-links': true,
    '@vuepress/last-updated': true
    // {
    //   transformer: (timestamp, lang) => {
    //     // Don't forget to install moment yourself
    //     const moment = require('moment')
    //     moment.locale(lang)
    //     return moment(timestamp).fromNow()
    //   }
    // }
  }
}
