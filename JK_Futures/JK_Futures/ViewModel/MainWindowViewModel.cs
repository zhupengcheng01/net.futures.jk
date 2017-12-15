using JK_Futures.ViewModel.MainAccount;
using MicroMvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace JK_Futures.ViewModel
{
   public class MainWindowViewModel: ObservableObject
    {
        private Visibility _IszhanShow = Visibility.Visible;
        private Visibility _IsshouShow = Visibility.Collapsed;

        private Visibility _IsChirdzhanShow = Visibility.Visible;
        private Visibility _IsChirdshouShow = Visibility.Collapsed;

        private MainAccountViewModel _MainAccount;
        public Visibility IszhanShow
        {
            get { return _IszhanShow; }
            set
            {
                if (_IszhanShow != value)
                {
                    _IszhanShow = value;
                    RaisePropertyChanged("IszhanShow");
                }
            }
        }
        public Visibility IsshouShow
        {
            get { return _IsshouShow; }
            set
            {
                if (_IsshouShow != value)
                {
                    _IsshouShow = value;
                    RaisePropertyChanged("IsshouShow");
                }
            }
        }

        public Visibility IsChirdzhanShow
        {
            get { return _IsChirdzhanShow; }
            set
            {
                if (_IsChirdzhanShow != value)
                {
                    _IsChirdzhanShow = value;
                    RaisePropertyChanged("IsChirdzhanShow");
                }
            }
        }
        public Visibility IsChirdshouShow
        {
            get { return _IsChirdshouShow; }
            set
            {
                if (_IsChirdshouShow != value)
                {
                    _IsChirdshouShow = value;
                    RaisePropertyChanged("IsChirdshouShow");
                }
            }
        }

        public MainAccountViewModel MainAccount
        {
            get { return _MainAccount; }
            set
            {
                if (_MainAccount != value)
                {
                    _MainAccount = value;
                    RaisePropertyChanged("MainAccount");
                }
            }
        }
        public MainWindowViewModel()
        {
            _MainAccount = new MainAccountViewModel();
        }



        #region 命令
        /// <summary>
        /// 主账号收缩
        /// </summary>
        public ICommand MainShouCommand { get { return new RelayCommand(ShouExecuteChanged, ShouCanExecuteChanged); } }
        public void ShouExecuteChanged()
        {
            IsshouShow = Visibility.Collapsed;
             IszhanShow = Visibility.Visible;
        }
        public bool ShouCanExecuteChanged()
        {
            return true;
        }
        /// <summary>
        /// 主账号展开
        /// </summary>
        public ICommand MainZhanCommand { get { return new RelayCommand(MainZhanExecuteChanged, MainZhanCanExecuteChanged); } }
        public void MainZhanExecuteChanged()
        {

            IszhanShow = Visibility.Collapsed;
            IsshouShow = Visibility.Visible;
        }
        public bool MainZhanCanExecuteChanged()
        {
            return true;
        }
        /// <summary>
        /// 主账号收缩
        /// </summary>
        public ICommand ChirdShouCommand { get { return new RelayCommand(ChirdShouExecuteChanged, ChirdShouCanExecuteChanged); } }
        public void ChirdShouExecuteChanged()
        {
            IsChirdshouShow = Visibility.Collapsed;
            IsChirdzhanShow = Visibility.Visible;
        }
        public bool ChirdShouCanExecuteChanged()
        {
            return true;
        }
        /// <summary>
        /// 主账号展开
        /// </summary>
        public ICommand ChirdZhanCommand { get { return new RelayCommand(ChirdZhanExecuteChanged, ChirdZhanCanExecuteChanged); } }
        public void ChirdZhanExecuteChanged()
        {

            IsChirdzhanShow = Visibility.Collapsed;
            IsChirdshouShow = Visibility.Visible;
        }
        public bool ChirdZhanCanExecuteChanged()
        {
            return true;
        }

        #endregion

    }
}
