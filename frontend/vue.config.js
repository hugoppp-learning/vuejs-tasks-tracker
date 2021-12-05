module.exports = {
  devServer: {
    proxy: {
      '^/api': {
        target: 'https://localhost:7276',
        changeOrigin: true,
        logLevel: 'debug',
        pathRewrite: { '^/api': '/' },
      },
    },
  },
}

