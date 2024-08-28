const { test, expect } = require('@playwright/test');

test('Check grades page', async ({ page }) => {
    await page.goto('http://localhost:8090/my-grades');
    const list = await page.$('li');
    expect(list).toBeTruthy();
  });
  