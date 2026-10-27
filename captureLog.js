import { format } from 'node:util';

// Runs fn and returns everything it printed with console.log, one array entry per call.
export function captureLog(fn) {
    const original = console.log;
    const lines = [];
    console.log = (...args) => lines.push(format(...args));
    try {
        fn();
    } finally {
        console.log = original;
    }
    return lines;
}
