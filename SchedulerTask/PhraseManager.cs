﻿using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SchedulerApp
{
    class Phrase
    {
        private int nounPosition; //-1 if none
        private int verbPosition; //-1 if none
        private string phrase;
        private bool isNamePresent;
        private int namePosition;

        public Phrase(string inPhrase, int inNounPosition = -1, int inVerbPosition = -1, 
                        bool inIsNamePresent = false, int inNamePosition = -1)
        {
            phrase = inPhrase;
            nounPosition = inNounPosition;
            verbPosition = inVerbPosition;
            isNamePresent = inIsNamePresent;
            namePosition = inNamePosition;
        }

        public string Text { get; set; }
        public int NounPosition { get; set; }
        public int VerbPosition { get; set; }
        public bool IsNamePresent { get; set; }
        public int NamePosition { get; set; }
    }

    class PhraseManager
    {
        private ArrayList phrases; //a dictionary might make more sense

        public PhraseManager(string filePath = "")
        {
            phrases = new ArrayList();

            if (filePath.Length > 0)
            {
                Load(filePath);
            }
        }

        public int AddPhrase(Phrase input)
        {
            if (!phrases.Contains(input))
            {
                phrases.Add(input);

                return 0;
            }

            return -1;
        }

        public int RemovePhrase(Phrase input)
        {
            if (!phrases.Contains(input))
            {
                return -1;
            }

            phrases.Remove(input);

            return 0;
        }

        public int RemovePhraseAt(int index)
        {
            if (index >= 0 && index < phrases.Count)
            {
                phrases.RemoveAt(index);
                return 0;
            }

            return -1;            
        }

        public Phrase PhraseAt(int index)
        {
            if (index >= PhraseCount())
            {
                return null;
            }

            return (Phrase)phrases[index];
        }

        public int PhraseCount()
        {
            return phrases.Count;
        }

        public int Load(string path)
        {
            //load phrases into container if path is valid
            //get root element
                //parse each phrase and call AddPhrase

            return 0;
        }

        public int Save(string path)
        {
            //save phrases into some base storage format
            XmlDocument phraseFile = new XmlDocument();
            XmlElement root = phraseFile.CreateElement("Phrases");

            phraseFile.DocumentElement.AppendChild(root);

            for (int i = 0; i < PhraseCount(); i++)
            {
                /*Phrase currentPhrase = PhraseAt(i);
                XmlElement child = phraseFile.CreateElement("Phrase");
                child.InnerText = currentPhrase.Text;
                XmlAttribute attribute = phraseFile.CreateAttribute("NounPosition");
                attribute.Value = currentPhrase.NounPosition.ToString();
                
                
                phraseFile.DocumentElement.AppendChild(child);*/
            }

            return 0;
        }
    }
}
