using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace homework {
    internal class English_FrenchDictionary {
        Dictionary<string, string[]> words;

        public English_FrenchDictionary() {
            words = new Dictionary<string, string[]>();
        }

        public void PrintWords() {
            Console.WriteLine("Словарь: ");
            foreach (KeyValuePair<string, string[]> item in words) {
                Console.WriteLine("Слово: {0}", item.Key);
                Console.WriteLine("Варианты перевода:");
                foreach (string wordsOptions in item.Value) {
                    Console.WriteLine(" - {0}", wordsOptions);
                }
                Console.WriteLine("");
            }
        }

        public void AddWord(string world, params string[] translationOptions) {
            words.Add(world, translationOptions);
        }

        public void RemoveWord(string word) {
            words.Remove(word);
        }

        // Удаление варианта перевода
        public void RemoveTranslation(string translationOptions) {
            string[] newListWords = null;
            string word = string.Empty;
            int i = 0;
            bool isNext = true;

            foreach (KeyValuePair<string, string[]> item in words) {
                word = item.Key;
                foreach (string wordsOptions in item.Value) {
                    if (wordsOptions == translationOptions) {
                        newListWords = new string[item.Value.Length - 1];
                        isNext = false;
                        break;
                    }
                }

                if (!isNext) { break; }
            }

            foreach (KeyValuePair<string, string[]> item in words) {
                if (word == item.Key) {
                    foreach (string wordsOptions in item.Value) {
                        if (wordsOptions != translationOptions) {
                            newListWords[i++] = wordsOptions;
                        }
                    }
                }
            }

            foreach (KeyValuePair<string, string[]> item in words) {
                if (word == item.Key) { words[word] = newListWords; }
            }
        }

        public void EditWord(string oldWord, string newWord) {
            foreach (KeyValuePair<string, string[]> item in words) {
                if (item.Key == oldWord) {
                    string[] oldListWords = item.Value;

                    words.Remove(oldWord);
                    words.Add(newWord, oldListWords);

                    break;
                }
            }
        }

        public void EditTranslation(string oldTranslation, string newTranslation) {
            foreach (KeyValuePair<string, string[]> item in words) {
                for (int i = 0; i < item.Value.Length; i++) {
                    if (item.Value[i] == oldTranslation) {
                        item.Value[i] = newTranslation;
                        break;
                    }
                }
            }
        }

        public void FindTranslation(string engWord) {
            foreach (KeyValuePair<string, string[]> item in words) {
                if (item.Key == engWord) {
                    foreach (string listWords in item.Value) {
                        Console.WriteLine(" - {0}", listWords);
                    }
                    Console.WriteLine("");
                }
            }
        }
    }
}
