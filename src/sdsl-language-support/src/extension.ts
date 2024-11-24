// The module 'vscode' contains the VS Code extensibility API
// Import the module and reference it with the alias vscode in your code below
import * as vscode from 'vscode';
import { LanguageClientOptions} from 'vscode-languageclient';
import { LanguageClient, ServerOptions, TransportKind } from 'vscode-languageclient/node';


import { Trace } from 'vscode-jsonrpc';
import { workspace } from 'vscode';
// This method is called when your extension is activated
// Your extension is activated the very first time the command is executed
export function activate(context: vscode.ExtensionContext) {

	// Use the console to output diagnostic information (console.log) and errors (console.error)
	// This line of code will only be executed once when your extension is activated
	console.log('Congratulations, your extension "sdsl-language-support" is now active!');

	// The command has been defined in the package.json file
	// Now provide the implementation of the command with registerCommand
	// The commandId parameter must match the command field in package.json
	const disposable = vscode.commands.registerCommand('sdsl-language-support.helloWorld', () => {
		// The code you place here will be executed every time your command is executed
		// Display a message box to the user
		vscode.window.showInformationMessage('Hello World from SDSL Language support!');
	});

	context.subscriptions.push(disposable);

	let serverExe = 'dotnet';
	let serverOptions: ServerOptions = {
		run: { command: serverExe, args: ["C:/Users/youness_kafia/Documents/dotnetProjs/SDSL/src/Stride.Shaders.LSP/bin/Debug/net9.0/Stride.Shaders.LSP.dll"] },
		debug: { command: serverExe, args: ["C:/Users/youness_kafia/Documents/dotnetProjs/SDSL/src/Stride.Shaders.LSP/bin/Debug/net9.0/Stride.Shaders.LSP.dll"] }
	};
	let clientOptions: LanguageClientOptions = {
		// Register the server for plain text documents
		documentSelector: [
			{
				pattern: '**/*.sdsl',
			}
		],
		synchronize: {
			// Synchronize the setting section 'languageServerExample' to the server
			configurationSection: 'languageServerExample',
			fileEvents: workspace.createFileSystemWatcher('**/*.sdsl')
		},
	};
	const client = new LanguageClient('languageServerExample', 'Language Server Example', serverOptions, clientOptions);
	// client.start();
}

// This method is called when your extension is deactivated
export function deactivate() {}
