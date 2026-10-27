import { expect } from 'chai';
import { captureLog } from '../../../captureLog.js';
import { solve as phoneBook } from '../13.PhoneBook.js';

describe('13.PhoneBook', () => {
    it('13 keeps the last phone number for duplicate names', () => {
        expect(captureLog(() => phoneBook(['Tim 0834212554', 'Peter 0877547887', 'Bill 0896543112', 'Tim 0876566344'])))
            .to.deep.equal(['Tim -> 0876566344', 'Peter -> 0877547887', 'Bill -> 0896543112']);
    });
});
