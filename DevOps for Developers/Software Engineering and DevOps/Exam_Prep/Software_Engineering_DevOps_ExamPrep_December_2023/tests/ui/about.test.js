const { test, expect } = require('@playwright/test');

test('Check about page', async ({ page }) => {
  await page.goto('https://software-engineering-devops-examprep-q73e.onrender.com/about');
  const heading = await page.$('h1');
  const text = await heading.textContent();
  expect(text).toBe('About');
});

test('Check about page test', async ({ page }) => {
  await page.goto('https://software-engineering-devops-examprep-q73e.onrender.com/about');
  const heading = await page.$('p');
  const text = await heading.textContent();
  expect(text).toBe('This is the Regular exam for Software Engineering and DevOps course @ SoftUni');
});
