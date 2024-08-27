const { test, expect } = require('@playwright/test')
const pageUrl = 'http://127.0.0.1:5500/to-do-app/';

// Test 1: Test If a User Can Go to Page

test('User can go to Page', async ({ page }) => {
    await page.goto(pageUrl);
    await expect(page).toHaveURL(pageUrl);
});


// Test 2: Test If a User Can Add a Task
test('User can add a task', async ({ page }) => {
    await page.goto(pageUrl);
    await page.fill('#task-input', 'New Task');
    await page.click('#add-task');
    const taskText = await page.textContent('.task');

    await expect(taskText).toContain('New Task');
});


//Test 3: Test If a User Can Delete a Task
test('User can delete a task', async ({ page }) => {
    await page.goto(pageUrl);

    await page.fill('#task-input', 'New Task 1');
    await page.click('#add-task');

    await page.fill('#task-input', 'New Task 2');
    await page.click('#add-task');

    await page.fill('#task-input', 'New Task 3');
    await page.click('#add-task');

    const firstTaskText = await page.textContent('#task-list');
    await expect(firstTaskText).toContain('New Task 1');

    const secondTaskText = await page.textContent('#task-list');
    await expect(secondTaskText).toContain('New Task 2');

    const thirdTaskText = await page.textContent('#task-list');
    await expect(thirdTaskText).toContain('New Task 3');

    const taskToDelete = "New Task 2";

    const taskLocator = page.locator(`#task-list .task:has-text("${taskToDelete}")`);

    // Ensure the specific task is present
    await expect(taskLocator).toContainText(taskToDelete);
    // Click the delete button for the specific task
    await taskLocator.locator('.delete-task').click();

    // Ensure the task is deleted
    await expect(page.locator('#task-list')).not.toContainText(taskToDelete);
});




//Test 4: Test If a User Can Mark a Task as Complete
test('User mark a task as complete', async ({ page }) => {

    await page.goto(pageUrl);
    await page.fill('#task-input', 'Test1')
    await page.click('#add-task');
    const testText1 = await page.textContent('#task-list');
    await expect(testText1).toContain('Test1');

    await page.fill('#task-input', 'Test2')
    await page.click('#add-task');

    const testText2 = await page.textContent('#task-list');
    await expect(testText2).toContain('Test2');

    const taskToComplete = "Test2";

    const taskLocator = page.locator(`#task-list .task:has-text("${taskToComplete}")`);

    // Ensure the specific task is present
    await expect(taskLocator).toContainText(taskToComplete);

    // Click the complete button for the specific task
    await taskLocator.locator('.task-complete').click();

    // Ensure the task is completed
    await expect(page.locator('#task-list')).toHaveCount(1);

    await expect(taskLocator).toHaveCount(1);
    await expect(taskLocator).toContainText('Test2');
    await expect(taskLocator).toHaveClass('task completed');

});


//Test 5: Test If a User Can Filter Tasks

test('user can filter tasks', async ({ page }) => {

    await page.goto(pageUrl);
    await page.fill('#task-input', 'Test Task 1');
    await page.click('#add-task');

    await page.fill('#task-input', 'Test Task 2');
    await page.click('#add-task');

    await page.fill('#task-input', 'Test Task 3');
    await page.click('#add-task');

    const taskToComplete = "Test Task 3";
    const taskLocator = page.locator(`#task-list .task:has-text("${taskToComplete}")`);

    // Ensure the specific task is present
    await expect(taskLocator).toContainText(taskToComplete);

    // Click the complete button for the specific task
    await taskLocator.locator('.task-complete').click();

    await page.selectOption('#filter', 'Completed');
    
    // Ensure the task is completed
    await expect(taskLocator).toContainText('Test Task 3');
    await expect(taskLocator).toHaveClass('task completed');
    

    await page.selectOption('#filter', 'All');
   
    const isFirstTaskCompleted = "Test Task 1";
    const isSecondTaskCompleted = "Test Task 2";
    const isThirdTaskCompleted = "Test Task 3";

    const firstTaskLocator = page.locator(`#task-list .task:has-text("${isFirstTaskCompleted}")`);
    const secondTaskLocator = page.locator(`#task-list .task:has-text("${isSecondTaskCompleted}")`);
    const thirdTaskLocator = page.locator(`#task-list .task:has-text("${isThirdTaskCompleted}")`);

    await expect(firstTaskLocator).not.toHaveClass('task completed');
    await expect(secondTaskLocator).not.toHaveClass('task completed');
    await expect(thirdTaskLocator).toHaveClass('task completed');

});