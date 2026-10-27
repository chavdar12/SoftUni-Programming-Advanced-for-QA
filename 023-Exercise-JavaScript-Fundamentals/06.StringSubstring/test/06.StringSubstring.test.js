import { expect } from 'chai';
import { captureLog } from '../../../captureLog.js';
import { solve as stringSubstring } from '../06.StringSubstring.js';

describe('06.StringSubstring', () => {
    it('06 finds a word case-insensitively', () => {
        expect(captureLog(() => stringSubstring('javascript', 'JavaScript is the best programming language')))
            .to.deep.equal(['javascript']);
        expect(captureLog(() => stringSubstring('JavaScript', 'I love javascript'))).to.deep.equal(['JavaScript']);
        expect(captureLog(() => stringSubstring('python', 'JavaScript is the best programming language')))
            .to.deep.equal(['python not found!']);
    });
});
