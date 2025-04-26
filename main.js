const vscode = require('vscode');

function activate(context) {
    const sayHiCommand = vscode.commands.registerCommand('sharp.SayHi', () => {
        vscode.window.showInformationMessage('Hello from Sharp Script!');
    });

    context.subscriptions.push(sayHiCommand);
}

function deactivate() {}

module.exports = {
    activate,
    deactivate
};
